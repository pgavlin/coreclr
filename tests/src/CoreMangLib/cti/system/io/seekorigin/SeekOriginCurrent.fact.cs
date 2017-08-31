using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_seekorigin_SeekOriginCurrent_SeekOriginCurrent_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_seekorigin_SeekOriginCurrent_SeekOriginCurrent_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\seekorigin\\SeekOriginCurrent\\SeekOriginCurrent.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
