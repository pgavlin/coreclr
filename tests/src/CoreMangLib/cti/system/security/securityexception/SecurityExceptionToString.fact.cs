using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_security_securityexception_SecurityExceptionToString_SecurityExceptionToString_
    {
        [OuterLoop]
        [Fact]
        public void _system_security_securityexception_SecurityExceptionToString_SecurityExceptionToString_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\security\\securityexception\\SecurityExceptionToString\\SecurityExceptionToString.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
