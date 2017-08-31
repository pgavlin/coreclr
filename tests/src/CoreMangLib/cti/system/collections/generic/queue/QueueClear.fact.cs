using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_queue_QueueClear_QueueClear_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_queue_QueueClear_QueueClear_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\queue\\QueueClear\\QueueClear.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
