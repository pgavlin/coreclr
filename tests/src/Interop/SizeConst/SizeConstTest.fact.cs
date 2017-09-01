using CoreclrTestLib;
using Xunit;

namespace Interop_SizeConst
{
    public class _SizeConstTest_SizeConstTest_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _SizeConstTest_SizeConstTest_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Interop\\SizeConst\\SizeConstTest\\SizeConstTest.cmd");
        }
    }
}
