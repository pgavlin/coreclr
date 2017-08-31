using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_type_TypeIsPointerImpl_TypeIsPointerImpl_
    {
        [OuterLoop]
        [Fact]
        public void _system_type_TypeIsPointerImpl_TypeIsPointerImpl_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\type\\TypeIsPointerImpl\\TypeIsPointerImpl.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
