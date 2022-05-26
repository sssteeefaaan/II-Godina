
public enum Country {
	
	SERBIA("RSD", "Belgrade", 7000000),
    USA("USD", "Washington DC", 327000000),
    RUSSIA("RUB", "Moscow", 144000000);

    public String currency;
    public String capital;
    public long population;

    Country(String currency, String capital, long population) {
        this.currency = currency;
        this.capital = capital;
        this.population = population;
    }

    public void showCountry() {
        System.out.println("Currency: " + currency + ", capital: " + capital + ", population: " + population);
    }

    public static void main(String args[]) {
    	
        Country s = Country.SERBIA;
        System.out.println(s);
        s.showCountry();
        int totalPopulation = 0;
        
        for(Country c: Country.values()) {
            totalPopulation += c.population;
            System.out.println(c.ordinal() + " " + c.name());
        }
        
        System.out.println("Total population is: " + totalPopulation);
        System.out.println(Country.valueOf("SERBIA"));
        System.out.println(Country.valueOf("USA"));
    }

}
