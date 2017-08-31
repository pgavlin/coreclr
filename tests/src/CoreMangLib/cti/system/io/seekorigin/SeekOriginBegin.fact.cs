using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_seekorigin_SeekOriginBegin_SeekOriginBegin_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_seekorigin_SeekOriginBegin_SeekOriginBegin_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\seekorigin\\SeekOriginBegin\\SeekOriginBegin.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
