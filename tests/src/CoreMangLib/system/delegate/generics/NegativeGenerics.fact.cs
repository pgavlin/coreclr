using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_system
{
    class _delegate_generics_NegativeGenerics_NegativeGenerics_
    {
        [OuterLoop]
        [Fact]
        public void _delegate_generics_NegativeGenerics_NegativeGenerics_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\system\\delegate\\generics\\NegativeGenerics\\NegativeGenerics.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
