using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_security_securityexception_SecurityExceptionCtor3_SecurityExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_security_securityexception_SecurityExceptionCtor3_SecurityExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\security\\securityexception\\SecurityExceptionCtor3\\SecurityExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
