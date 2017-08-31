using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_security_securityexception_SecurityExceptionCtor1_SecurityExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_security_securityexception_SecurityExceptionCtor1_SecurityExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\security\\securityexception\\SecurityExceptionCtor1\\SecurityExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
