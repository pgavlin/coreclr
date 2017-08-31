using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_array_ArrayGetEnumerator_ArrayGetEnumerator_
    {
        [OuterLoop]
        [Fact]
        public void _system_array_ArrayGetEnumerator_ArrayGetEnumerator_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\array\\ArrayGetEnumerator\\ArrayGetEnumerator.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
