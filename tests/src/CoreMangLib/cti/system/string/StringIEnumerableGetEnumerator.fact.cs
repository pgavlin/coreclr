using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringIEnumerableGetEnumerator_StringIEnumerableGetEnumerator_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringIEnumerableGetEnumerator_StringIEnumerableGetEnumerator_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringIEnumerableGetEnumerator\\StringIEnumerableGetEnumerator.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
