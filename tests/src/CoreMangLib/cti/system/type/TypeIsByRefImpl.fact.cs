using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_type_TypeIsByRefImpl_TypeIsByRefImpl_
    {
        [OuterLoop]
        [Fact]
        public void _system_type_TypeIsByRefImpl_TypeIsByRefImpl_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\type\\TypeIsByRefImpl\\TypeIsByRefImpl.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
