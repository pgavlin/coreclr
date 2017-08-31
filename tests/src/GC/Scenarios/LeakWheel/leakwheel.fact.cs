using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _LeakWheel_leakwheel_leakwheel_
    {
        [Fact]
        public void _LeakWheel_leakwheel_leakwheel_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\LeakWheel\\leakwheel\\leakwheel.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
