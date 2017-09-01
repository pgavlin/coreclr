using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    public class _system_attribute_GetHashCode_GetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_attribute_GetHashCode_GetHashCode_cmd()
        {
            CoreclrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\attribute\\GetHashCode\\GetHashCode.cmd");
        }
    }
}
