using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_eventattributes_EventAttributesSpecialName_EventAttributesSpecialName_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_eventattributes_EventAttributesSpecialName_EventAttributesSpecialName_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\eventattributes\\EventAttributesSpecialName\\EventAttributesSpecialName.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
