using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _LeakGen_leakgen_leakgen_
    {
        [OuterLoop]
        [Fact]
        public void _LeakGen_leakgen_leakgen_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\LeakGen\\leakgen\\leakgen.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
