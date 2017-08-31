using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_seekorigin_SeekOriginEnd_SeekOriginEnd_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_seekorigin_SeekOriginEnd_SeekOriginEnd_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\seekorigin\\SeekOriginEnd\\SeekOriginEnd.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
