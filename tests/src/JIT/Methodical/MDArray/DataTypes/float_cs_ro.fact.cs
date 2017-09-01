using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _MDArray_DataTypes_float_cs_ro_float_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _MDArray_DataTypes_float_cs_ro_float_cs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\DataTypes\\float_cs_ro\\float_cs_ro.cmd");
        }
    }
}
