using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderctor6_StringBuilderctor6_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderctor6_StringBuilderctor6_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderctor6\\StringBuilderctor6.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
