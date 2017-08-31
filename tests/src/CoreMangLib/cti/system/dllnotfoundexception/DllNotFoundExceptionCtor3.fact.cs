using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_dllnotfoundexception_DllNotFoundExceptionCtor3_DllNotFoundExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_dllnotfoundexception_DllNotFoundExceptionCtor3_DllNotFoundExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\dllnotfoundexception\\DllNotFoundExceptionCtor3\\DllNotFoundExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
