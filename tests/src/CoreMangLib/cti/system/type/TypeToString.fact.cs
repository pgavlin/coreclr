using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_type_TypeToString_TypeToString_
    {
        [OuterLoop]
        [Fact]
        public void _system_type_TypeToString_TypeToString_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\type\\TypeToString\\TypeToString.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
