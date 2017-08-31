using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_typecode_TypeCodeEmpty_TypeCodeEmpty_
    {
        [OuterLoop]
        [Fact]
        public void _system_typecode_TypeCodeEmpty_TypeCodeEmpty_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\typecode\\TypeCodeEmpty\\TypeCodeEmpty.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
