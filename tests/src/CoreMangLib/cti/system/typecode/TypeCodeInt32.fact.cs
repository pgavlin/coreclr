using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_typecode_TypeCodeInt32_TypeCodeInt32_
    {
        [OuterLoop]
        [Fact]
        public void _system_typecode_TypeCodeInt32_TypeCodeInt32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\typecode\\TypeCodeInt32\\TypeCodeInt32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
