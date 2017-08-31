using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_typecode_TypeCodeUInt32_TypeCodeUInt32_
    {
        [OuterLoop]
        [Fact]
        public void _system_typecode_TypeCodeUInt32_TypeCodeUInt32_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\typecode\\TypeCodeUInt32\\TypeCodeUInt32.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
