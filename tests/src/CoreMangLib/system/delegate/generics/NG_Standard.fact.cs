using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_system
{
    class _delegate_generics_NG_Standard_NG_Standard_
    {
        [OuterLoop]
        [Fact]
        public void _delegate_generics_NG_Standard_NG_Standard_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\system\\delegate\\generics\\NG_Standard\\NG_Standard.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
