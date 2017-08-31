using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_typecode_TypeCodeUInt16_TypeCodeUInt16_
    {
        [OuterLoop]
        [Fact]
        public void _system_typecode_TypeCodeUInt16_TypeCodeUInt16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\typecode\\TypeCodeUInt16\\TypeCodeUInt16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
