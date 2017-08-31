using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_type_TypeMakeArrayType2_TypeMakeArrayType2_
    {
        [OuterLoop]
        [Fact]
        public void _system_type_TypeMakeArrayType2_TypeMakeArrayType2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\type\\TypeMakeArrayType2\\TypeMakeArrayType2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
