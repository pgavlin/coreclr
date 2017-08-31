using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_typecode_TypeCodeDateTime_TypeCodeDateTime_
    {
        [OuterLoop]
        [Fact]
        public void _system_typecode_TypeCodeDateTime_TypeCodeDateTime_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\typecode\\TypeCodeDateTime\\TypeCodeDateTime.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
