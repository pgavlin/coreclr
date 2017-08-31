using CoreclrTestLib;
using Xunit;

namespace GC_Features
{
    class _BackgroundGC_foregroundgc_foregroundgc_
    {
        [ActiveIssue("3392")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _BackgroundGC_foregroundgc_foregroundgc_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Features\\BackgroundGC\\foregroundgc\\foregroundgc.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
