using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_queue_QueueGetEnumerator_QueueGetEnumerator_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_queue_QueueGetEnumerator_QueueGetEnumerator_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\queue\\QueueGetEnumerator\\QueueGetEnumerator.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
