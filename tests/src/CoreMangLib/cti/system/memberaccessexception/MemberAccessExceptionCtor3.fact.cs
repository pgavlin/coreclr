using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_memberaccessexception_MemberAccessExceptionCtor3_MemberAccessExceptionCtor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_memberaccessexception_MemberAccessExceptionCtor3_MemberAccessExceptionCtor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\memberaccessexception\\MemberAccessExceptionCtor3\\MemberAccessExceptionCtor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
