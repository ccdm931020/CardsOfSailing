using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class EducationNode
{
    public static EducationNode Instance;
    public Camera mainCamera { get; private set; }

    public void start()
    {
        EducationNode.Instance = this;
        this.mainCamera = Camera.main;
        
        this.startData();
        this.startUnit();
    }

    public void update(float dt)
    {
        this.updateData(dt);
        this.updateUnit(dt);
    }

    public void stop()
    {
        this.stopUnit();
        this.stopData();
        EducationNode.Instance = null;
    }
}
