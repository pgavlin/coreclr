using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_typeattributes_TypeAttribytesNotPublic_TypeAttribytesNotPublic_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_typeattributes_TypeAttribytesNotPublic_TypeAttribytesNotPublic_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\typeattributes\\TypeAttribytesNotPublic\\TypeAttribytesNotPublic.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
