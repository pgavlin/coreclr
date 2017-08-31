using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _MinLeakGen_minleakgen_minleakgen_
    {
        [Fact]
        public void _MinLeakGen_minleakgen_minleakgen_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\MinLeakGen\\minleakgen\\minleakgen.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
