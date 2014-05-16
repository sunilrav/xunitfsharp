module MyTests

open Xunit

type myTest1() = class

    [<Fact>]
    member self.myTest() =
       Assert.Equal(1, 1);

end
