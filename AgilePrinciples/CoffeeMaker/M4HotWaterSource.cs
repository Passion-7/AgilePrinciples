using AgilePrinciples.CoffeeMaker.Api;
using System;

namespace AgilePrinciples.CoffeeMaker; 

public class M4HotWaterSource : HotWaterSource, Pollable {
    private CoffeeMakerAPI api;

    public M4HotWaterSource(CoffeeMakerAPI api) {
        this.api = api;
    }
    
    public override bool IsReady() {
        BoilerStatus status = api.GetBoilerStatus() ;
        return status == BoilerStatus.NOT_EMPTY;
    }

    public override void StartBrewing() {
        api.SetReliefValveState(ReliefValveState.CLOSED);
        api.SetBoilerButtonState(BoilerState.ON);
    }

    public void Poll() {
        BoilerStatus boilerStatus = api.GetBoilerStatus();
        if (isBrewing) {
            if (boilerStatus == BoilerStatus.EMPTY) {
                api.SetBoilerButtonState(BoilerState.OFF);
                api.SetReliefValveState(ReliefValveState.CLOSED);
                DeclareDone();
            }
        }
    }

    public override void Pause() {
        api.SetBoilerButtonState(BoilerState.OFF);
        api.SetReliefValveState(ReliefValveState.OPEN);
    }

    public override void Resume() {
        api.SetBoilerButtonState(BoilerState.ON);
        api.SetReliefValveState(ReliefValveState.CLOSED);
    }
}