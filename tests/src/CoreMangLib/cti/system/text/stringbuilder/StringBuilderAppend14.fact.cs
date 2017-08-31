using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderAppend14_StringBuilderAppend14_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderAppend14_StringBuilderAppend14_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderAppend14\\StringBuilderAppend14.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
