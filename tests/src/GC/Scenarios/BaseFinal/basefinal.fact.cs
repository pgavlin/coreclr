using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _BaseFinal_basefinal_basefinal_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _BaseFinal_basefinal_basefinal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\BaseFinal\\basefinal\\basefinal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
