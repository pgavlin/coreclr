using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_system
{
    class _buffer_ASURT_99893_ASURT_99893_
    {
        [OuterLoop]
        [Fact]
        public void _buffer_ASURT_99893_ASURT_99893_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\system\\buffer\\ASURT_99893\\ASURT_99893.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
