using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_typecode_TypeCodeUInt64_TypeCodeUInt64_
    {
        [OuterLoop]
        [Fact]
        public void _system_typecode_TypeCodeUInt64_TypeCodeUInt64_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\typecode\\TypeCodeUInt64\\TypeCodeUInt64.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
