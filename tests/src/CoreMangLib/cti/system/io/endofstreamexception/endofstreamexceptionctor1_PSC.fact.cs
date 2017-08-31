using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_endofstreamexception_endofstreamexceptionctor1_PSC_endofstreamexceptionctor1_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_endofstreamexception_endofstreamexceptionctor1_PSC_endofstreamexceptionctor1_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\endofstreamexception\\endofstreamexceptionctor1_PSC\\endofstreamexceptionctor1_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
