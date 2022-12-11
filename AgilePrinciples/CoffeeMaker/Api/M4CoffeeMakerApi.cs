namespace AgilePrinciples.CoffeeMaker.Api; 

public class M4CoffeeMakerApi : CoffeeMakerAPI {
    public WarmerPlateStatus GetWarmerPlateStatus() {
        throw new NotImplementedException();
    }

    public BoilerStatus GetBoilerStatus() {
        throw new NotImplementedException();
    }

    public BrewButtonStatus GetBrewButtonStatus() {
        throw new NotImplementedException();
    }

    public void SetBoilerButtonState(BoilerState s) {
        throw new NotImplementedException();
    }

    public void SetWarmerState(WarmerState s) {
        throw new NotImplementedException();
    }

    public void SetIndicatorState(IndicatorState s) {
        throw new NotImplementedException();
    }

    public void SetReliefValveState(ReliefValveState s) {
        throw new NotImplementedException();
    }
}