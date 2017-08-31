using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_runtime_interopservices_layoutkind_LayoutKindAuto_LayoutKindAuto_
    {
        [OuterLoop]
        [Fact]
        public void _system_runtime_interopservices_layoutkind_LayoutKindAuto_LayoutKindAuto_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\runtime\\interopservices\\layoutkind\\LayoutKindAuto\\LayoutKindAuto.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
