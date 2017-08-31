using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _Affinity_affinitizer_affinitizer_
    {
        [OuterLoop]
        [Fact]
        public void _Affinity_affinitizer_affinitizer_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\Affinity\\affinitizer\\affinitizer.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
