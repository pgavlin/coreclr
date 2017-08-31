using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_methodaccessexception_MethodAccessExceptionCtor2_MethodAccessExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_methodaccessexception_MethodAccessExceptionCtor2_MethodAccessExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\methodaccessexception\\MethodAccessExceptionCtor2\\MethodAccessExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
