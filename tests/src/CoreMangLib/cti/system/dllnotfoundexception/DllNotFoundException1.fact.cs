using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_dllnotfoundexception_DllNotFoundException1_DllNotFoundException1_
    {
        [OuterLoop]
        [Fact]
        public void _system_dllnotfoundexception_DllNotFoundException1_DllNotFoundException1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\dllnotfoundexception\\DllNotFoundException1\\DllNotFoundException1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
