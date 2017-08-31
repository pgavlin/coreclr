using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_activator_ActivatorCreateInstance2_ActivatorCreateInstance2_
    {
        [OuterLoop]
        [Fact]
        public void _system_activator_ActivatorCreateInstance2_ActivatorCreateInstance2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\activator\\ActivatorCreateInstance2\\ActivatorCreateInstance2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
