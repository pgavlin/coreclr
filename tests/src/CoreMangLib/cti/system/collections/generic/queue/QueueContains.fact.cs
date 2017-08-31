using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_queue_QueueContains_QueueContains_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_queue_QueueContains_QueueContains_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\queue\\QueueContains\\QueueContains.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
