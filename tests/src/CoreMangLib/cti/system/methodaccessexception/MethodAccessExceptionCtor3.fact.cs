using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_methodaccessexception_MethodAccessExceptionCtor3_MethodAccessExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_methodaccessexception_MethodAccessExceptionCtor3_MethodAccessExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\methodaccessexception\\MethodAccessExceptionCtor3\\MethodAccessExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
