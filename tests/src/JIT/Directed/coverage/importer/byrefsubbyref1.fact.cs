using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    public class _coverage_importer_byrefsubbyref1_byrefsubbyref1_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_importer_byrefsubbyref1_byrefsubbyref1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\byrefsubbyref1\\byrefsubbyref1.cmd");
        }
    }
}
