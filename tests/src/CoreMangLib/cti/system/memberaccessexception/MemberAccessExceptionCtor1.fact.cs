using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_memberaccessexception_MemberAccessExceptionCtor1_MemberAccessExceptionCtor1_
    {
        [OuterLoop]
        [Fact]
        public void _system_memberaccessexception_MemberAccessExceptionCtor1_MemberAccessExceptionCtor1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\memberaccessexception\\MemberAccessExceptionCtor1\\MemberAccessExceptionCtor1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
