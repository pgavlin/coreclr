using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _clr_x64_JIT_v4_0_devdiv374539_DevDiv_374539_DevDiv_374539_
    {
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _clr_x64_JIT_v4_0_devdiv374539_DevDiv_374539_DevDiv_374539_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\clr-x64-JIT\\v4.0\\devdiv374539\\DevDiv_374539\\DevDiv_374539.cmd");
        }
    }
}
