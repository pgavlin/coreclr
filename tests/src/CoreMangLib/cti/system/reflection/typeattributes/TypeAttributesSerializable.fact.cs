using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_reflection_typeattributes_TypeAttributesSerializable_TypeAttributesSerializable_
    {
        [OuterLoop]
        [Fact]
        public void _system_reflection_typeattributes_TypeAttributesSerializable_TypeAttributesSerializable_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\reflection\\typeattributes\\TypeAttributesSerializable\\TypeAttributesSerializable.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
