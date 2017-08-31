using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_memberaccessexception_MemberAccessExceptionCtor2_MemberAccessExceptionCtor2_
    {
        [OuterLoop]
        [Fact]
        public void _system_memberaccessexception_MemberAccessExceptionCtor2_MemberAccessExceptionCtor2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\memberaccessexception\\MemberAccessExceptionCtor2\\MemberAccessExceptionCtor2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
