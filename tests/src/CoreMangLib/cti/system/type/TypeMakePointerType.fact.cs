using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_type_TypeMakePointerType_TypeMakePointerType_
    {
        [OuterLoop]
        [Fact]
        public void _system_type_TypeMakePointerType_TypeMakePointerType_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\type\\TypeMakePointerType\\TypeMakePointerType.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
