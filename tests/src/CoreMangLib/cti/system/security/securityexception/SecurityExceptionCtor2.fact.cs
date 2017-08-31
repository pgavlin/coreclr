using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_security_securityexception_SecurityExceptionCtor2_SecurityExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_security_securityexception_SecurityExceptionCtor2_SecurityExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\security\\securityexception\\SecurityExceptionCtor2\\SecurityExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
