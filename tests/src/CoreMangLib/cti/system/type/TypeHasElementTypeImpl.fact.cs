using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_type_TypeHasElementTypeImpl_TypeHasElementTypeImpl_
    {
        [OuterLoop]
        [Fact]
        public void _system_type_TypeHasElementTypeImpl_TypeHasElementTypeImpl_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\type\\TypeHasElementTypeImpl\\TypeHasElementTypeImpl.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
