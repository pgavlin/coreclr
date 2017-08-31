using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_type_TypeMakeArrayType1_TypeMakeArrayType1_
    {
        [OuterLoop]
        [Fact]
        public void _system_type_TypeMakeArrayType1_TypeMakeArrayType1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\type\\TypeMakeArrayType1\\TypeMakeArrayType1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
