using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderCapacity_StringBuilderCapacity_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderCapacity_StringBuilderCapacity_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderCapacity\\StringBuilderCapacity.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
