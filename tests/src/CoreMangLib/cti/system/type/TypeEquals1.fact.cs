using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_type_TypeEquals1_TypeEquals1_
    {
        [OuterLoop]
        [Fact]
        public void _system_type_TypeEquals1_TypeEquals1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\type\\TypeEquals1\\TypeEquals1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
