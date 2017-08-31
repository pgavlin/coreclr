using CoreclrTestLib;
using Xunit;

namespace JIT_Generics
{
    class _Fields_getclassfrommethodparam_getclassfrommethodparam_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _Fields_getclassfrommethodparam_getclassfrommethodparam_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Generics\\Fields\\getclassfrommethodparam\\getclassfrommethodparam.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
